using System;
using System.IO;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace WebUI.Utils
{
    public static class FileManager
    {
        public static async Task SaveSchedule(IFormFile file, User user)
        {
            var date = DateTime.Now.ToString("dd-MM-yyyyTHH:mm");
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/storage", 
                $"{date}__{user.Id}.pdf");
            
            using (var stream = File.Create(filePath))
            {
                await file.CopyToAsync(stream);
            }
        }
    }
}