using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosTeste.Services
{
    public class UploadFile : IUploadFile
    {

    #pragma warning disable CS0618 // O tipo ou membro é obsoleto
        private readonly IHostingEnvironment _hostingEnvironment;
    #pragma warning restore CS0618 // O tipo ou membro é obsoleto


    #pragma warning disable CS0618 // O tipo ou membro é obsoleto
        public UploadFile(IHostingEnvironment hostingEnvironment)
    #pragma warning restore CS0618 // O tipo ou membro é obsoleto
        {
            this._hostingEnvironment = hostingEnvironment;
        }

         public string Upload(IFormFile formFile)
        {
            try
            {
                var nomeArquivo = formFile.FileName;
                var novoNomeArquivo = nomeArquivo.Replace(" ", "_");
                string pastaArquivos = Path.Combine(_hostingEnvironment.WebRootPath, "arquivos");
                string caminhoArquivo = Path.Combine(pastaArquivos, novoNomeArquivo);
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
                return novoNomeArquivo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}
