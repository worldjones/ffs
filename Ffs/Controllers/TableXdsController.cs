using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Ffs.Models.EF;

namespace Ffs.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TableXdsController : Controller
    {
        private ExcelContext _context;

        public TableXdsController(ExcelContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions) {
            var tablexds = _context.TableXds.Select(i => new {
                i.KeyId,
                i.TableId,
                i.RowId,
                i.TestInput,
                i.AcceptanceCriteria
            }).ToList(); 



            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "KeyId" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(DataSourceLoader.Load(tablexds, loadOptions));
        }

      

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new TableXd();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.TableXds.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.KeyId });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            var model = await _context.TableXds.FirstOrDefaultAsync(item => item.KeyId == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            var model = await _context.TableXds.FirstOrDefaultAsync(item => item.KeyId == key);

            _context.TableXds.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(TableXd model, IDictionary values) {
            string KEY_ID = nameof(TableXd.KeyId);
            string TABLE_ID = nameof(TableXd.TableId);
            string ROW_ID = nameof(TableXd.RowId);
            string TEST_INPUT = nameof(TableXd.TestInput);
            string ACCEPTANCE_CRITERIA = nameof(TableXd.AcceptanceCriteria);

            if(values.Contains(KEY_ID)) {
                model.KeyId = Convert.ToString(values[KEY_ID]);
            }

            if(values.Contains(TABLE_ID)) {
                model.TableId = Convert.ToString(values[TABLE_ID]);
            }

            if(values.Contains(ROW_ID)) {
                model.RowId = Convert.ToString(values[ROW_ID]);
            }

            if(values.Contains(TEST_INPUT)) {
                model.TestInput = Convert.ToString(values[TEST_INPUT]);
            }

            if(values.Contains(ACCEPTANCE_CRITERIA)) {
                model.AcceptanceCriteria = Convert.ToString(values[ACCEPTANCE_CRITERIA]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}