using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsManager.Core.ServicesContracts;

/// <summary>
/// Represents business logic (bulk insert) for manipulating Country entity
/// </summary>
public interface ICountriesUploaderService
{
    /// <summary>
    /// Uploads countries from excel file into database
    /// </summary>
    /// <param name="formFile">Excel file with list of countries</param>
    /// <returns>Returns number of countries added</returns>
    Task<int> UploadCountriesFromExcelFile(IFormFile formFile);
}
