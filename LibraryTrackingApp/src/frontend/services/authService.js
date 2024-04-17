import customAxios from "@/utils/customAxios";

const AUTH_BASE_API_URL = `/api/v1/auths`;
// düzenlenecek.

//register ve login endpointlerine istek atıcak...

const AuthService = {
  login: async (loginData) => {
    const response = await customAxios.post(AUTH_BASE_API_URL, loginData);
    return response.json()
  },
  register: async (registerData) => {
    const response = await customAxios.post(AUTH_BASE_API_URL, loginData);
    return response.json()
  },

};



export default new AuthService;
