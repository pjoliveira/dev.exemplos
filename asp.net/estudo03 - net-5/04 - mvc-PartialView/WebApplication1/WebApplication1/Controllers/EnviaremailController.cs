using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class EnviarEmailController : Controller
    {

        public EmailSettings _emailSettings { get; }

        public EnviarEmailController(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public IActionResult Index()
        {
      
            return View();
        }

        public IActionResult EnviaEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviaEmail(EmailModel email)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SendMail(email.Destino, email.Assunto, email.Mensagem); 
                    //TesteEnvioEmail(email.Destino, email.Assunto, email.Mensagem).GetAwaiter();
                    return RedirectToAction("EmailEnviado");
                }
                catch (Exception)
                {
                    return RedirectToAction("EmailFalhou");
                }
            }
            return View(email);
        }

        //public async Task TesteEnvioEmail(string email, string assunto, string mensagem)
        //{
        //    try
        //    {
        //        //email destino, assunto do email, mensagem a enviar
        //        await _emailSender.SendEmailAsync(email, assunto, mensagem);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public ActionResult EmailEnviado()
        {
            return View();
        }

        public ActionResult EmailFalhou()
        {
            return View();
        }

        public bool SendMail(string email, string assunto, string mensagem)
        {
            try
            {
                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage();
                // Remetente
                _mailMessage.From = new MailAddress("emanager.corp@gmail.com"); //EMAIL DO REMETENTE

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add(_emailSettings.ToEmail);  // email
                _mailMessage.Subject = "Contato Site - " + assunto;
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "<b>"+ email + "</b><p>"+ mensagem + "</p>";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                //CONFIGURAÇÃO SEM PORTA
                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("emanager.corp@gmail.com", "em123QWE!@#");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_mailMessage);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
