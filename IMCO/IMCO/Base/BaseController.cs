using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using IMCO.Core.Base;
using IMCO.Core.Constants;
using IMCO.Core.Enums;
using IMCO.Core.Extensions;
using IMCO.Models;
using Newtonsoft.Json;

namespace IMCO.Base
{
    public class BaseController : Controller
    {
        // GET: Base
        protected T Get<T>(string url, bool includeAccessToken = true)
        {
            try
            {
                using (var client = GetHttpClient(includeAccessToken))
                {
                    var offSetTime = "0";
                    if (Session["OffsetTime"] != null)
                    {
                        offSetTime = Session["OffsetTime"].ToString();
                        client.DefaultRequestHeaders.Add("CustomOffsetTime", offSetTime);
                    }
                    var responseMsg = client.GetAsync(url).Result;
                    if (responseMsg.IsSuccessStatusCode)
                    {
                        var responseString = responseMsg.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<T>(responseString);
                    }
                    else
                    {
                        var responseString = responseMsg.Content.ReadAsStringAsync().Result;
                        var model = JsonConvert.DeserializeObject<ApiExceptionModel>(responseString);
                        throw new Exception($"{model.Message} - ({model.ExceptionMessage})");
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.GetAllMessages();
                //var dto = new T();
                //if (dto is ResponseDto)
                //    (dto as ResponseDto).ErrorMessages.Add(message);
                AddNotification(NotifyType.Error, message, false);
                return default(T);
            }
        }

        private HttpClient GetHttpClient(bool includeAccessToken = false)
        {
            var client = new HttpClient();
            client.Timeout = Timeout.InfiniteTimeSpan;
            client.BaseAddress = new Uri(Core.Helpers.AppSettingsReader.ReadString(AppSettingsKeys.ServiceUrl));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //if (includeAccessToken)
            //{
            //    var accessToken = GetAccessToken();
            //    if (string.IsNullOrWhiteSpace(accessToken) == false)
            //        client.DefaultRequestHeaders.Add(ApplicationConstants.HeaderKeys.AccessToken, accessToken);
            //}
            return client;
        }

        protected void AddErrorNotification(List<string> messages, bool persistForTheNextRequest)
        {
            if (messages != null && messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    if (string.IsNullOrWhiteSpace(message) == false)
                        AddNotification(NotifyType.Error, message, persistForTheNextRequest);
                }
            }
        }

        private void AddNotification(NotifyType type, string message, bool persistForTheNextRequest)
        {
            var dataKey = $"notifications.{type}";
            if (persistForTheNextRequest)
            {
                if (TempData[dataKey] == null)
                    TempData[dataKey] = new List<string>();
                ((List<string>)TempData[dataKey]).Add(message);
            }
            else
            {
                if (ViewData[dataKey] == null)
                    ViewData[dataKey] = new List<string>();
                ((List<string>)ViewData[dataKey]).Add(message);
            }
        }
    }
}