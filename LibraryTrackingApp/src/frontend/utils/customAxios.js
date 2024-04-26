import { site } from "@/constants/site";
import axios from "axios";

const API_BASE_URL = site.API_BASE_URL;

const customAxios = axios.create({
  baseURL: API_BASE_URL,
  timeout: 5000,
  headers: {
    "Content-Type": "application/json",
  },
});

customAxios.interceptors.request.use(
  function (config) {
    return config;
  },
  function (error) {
    return Promise.reject(error);
  }
);

customAxios.interceptors.response.use(
  function (response) {
    return response;
  },
  function (error) {
 
    
    if (error.response && error.response.status === 500) {
      alert("Beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyin.");
    } else if (error.response && error.response.status === 401) {
      alert("Oturum süreniz doldu. Lütfen tekrar giriş yapın.");
    } else if (error.response && error.response.status === 403) {
      alert("Bu işlemi gerçekleştirme yetkiniz bulunmamaktadır.");
    } else if (error.response && error.response.status === 404) {
      alert("İstenilen kaynak bulunamadı.");
    } else if (error.response && error.response.status === 409) {
      alert("İstenilen kaynak zaten mevcut.");
    } else {
      alert(
        "Sunucuya bağlanırken bir hata oluştu. Lütfen daha sonra tekrar deneyin."
      );
    }

  

    //return Promise.reject(error);
    return Promise.resolve(); // Hata yok gibi davranıyoruz
  }
);

export default customAxios;
