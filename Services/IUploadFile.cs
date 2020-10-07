using Microsoft.AspNetCore.Http;

namespace LivrosTeste.Services  
{
    public interface IUploadFile
    {
        string Upload(IFormFile formFile);
    }
}