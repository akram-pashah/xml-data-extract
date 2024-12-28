using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using XmlDataExtract.Models;

namespace XmlDataExtract.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlController : ControllerBase
    {
        [HttpPost("GetXmlData")]
        public async Task<IActionResult> GetXmlData(IFormFile formFile)
        {
            try
            {
                XactDoc doc = new();
                FileStream fileStream= await GetFileStreamFromFormFile(formFile);
                doc = await ProcessXmlFileStream(fileStream);
                return Ok(doc);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        static async Task<FileStream> GetFileStreamFromFormFile(IFormFile formFile)
        {
            try
            {
                string fileName = Path.GetTempFileName();

                using (FileStream fileStream = new(fileName, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }

                return new FileStream(fileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static async Task<XactDoc> ProcessXmlFileStream(FileStream fileStream)
        {
            XactDoc result;

            try
            {
                using StreamReader reader = new StreamReader(fileStream);
                string xmlContent = await reader.ReadToEndAsync();
                Console.WriteLine($"XML Content:\n{xmlContent}");


                using StringReader stringReader = new StringReader(xmlContent);
                XmlSerializer serializer = new XmlSerializer(typeof(XactDoc));
                using XmlReader xmlReader = XmlReader.Create(stringReader);
                var data = serializer.Deserialize(xmlReader);
                if (data != null)
                {
                    result = (XactDoc)data;
                    return result;
                }
                else
                {
                    throw new Exception("Serialized data has no value.");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
