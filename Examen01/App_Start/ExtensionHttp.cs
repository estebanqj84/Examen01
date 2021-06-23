using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Examen01
{
    public static class ExtensionHttp
    {

        //public static async Task<T> AxiosGetAsync<T>(this HttpClient axios, string url)
        //{
        //    using (var result = axios.GetFromJsonAsync<T>(url))
        //    {

        //        return await result;
        //    }
        //}

        //public async static Task<T> AxiosDeleteAsync<T>(this HttpClient httpClient, string Url)
        //{
        //    using (var result = await httpClient.DeleteAsync(Url))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;

        //        return await result.Content.ReadFromJsonAsync<T>();
        //    }
        //}

        //public static async Task<TResult> AxiosPostAsync<TSend, TResult>(this HttpClient axios, string url, TSend send)
        //{
        //    using (var result = await axios.PostAsJsonAsync(url, send))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);
        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;
        //        return await result.Content.ReadFromJsonAsync<TResult>();
        //    }
        //}
        //public static async Task<TResult> AxiosPostAsync<TResult>(this HttpClient axios, string url)
        //{

        //    using (var result = await axios.PostAsJsonAsync(url, ""))
        //    {

        //        var test = new JsonSerializerOptions { };
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;

        //        return await result.Content.ReadFromJsonAsync<TResult>();
        //    }
        //}


        //public static async Task<TResult> AxiosPostAsync<TResult>(this HttpClient axios, string url, TResult send)
        //{

        //    using (var result = await axios.PostAsJsonAsync(url, send))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);
        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;
        //        return await result.Content.ReadFromJsonAsync<TResult>();
        //    }
        //}

        //public static async Task<string> AxiosPostAsStringAsync<TResult>(this HttpClient axios, string url, TResult send)
        //{

        //    using (var result = await axios.PostAsJsonAsync(url, send))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

        //        return await result.Content.ReadAsStringAsync();
        //    }
        //}

        //public static async Task<string> AxiosPostAsStringAsync(this HttpClient axios, string url)
        //{

        //    using (var result = await axios.PostAsJsonAsync(url, ""))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

        //        return await result.Content.ReadAsStringAsync();
        //    }
        //}

        //public static async Task<TResult> AxiosPutAsync<TResult, TSend>(this HttpClient axios, string url, TSend send)
        //{
        //    using (var result = await axios.PutAsJsonAsync(url, send))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);
        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;
        //        return await result.Content.ReadFromJsonAsync<TResult>();
        //    }
        //}

        //public static async Task<TResult> AxiosPutAsync<TResult>(this HttpClient axios, string url)
        //{

        //    using (var result = await axios.PutAsJsonAsync(url, ""))
        //    {
        //        if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);
        //        if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return default;
        //        return await result.Content.ReadFromJsonAsync<TResult>();
        //    }
        //}


    }
}
