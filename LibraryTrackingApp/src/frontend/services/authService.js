import customAxios from "@/utils/customAxios";
const AUTH_BASE_API_URL = `/api/v1/auths`;

const AuthService = {
  login: async (loginData) => {
    const response = await customAxios.post(`${AUTH_BASE_API_URL}/login`, loginData);
    return response.data;
  },
  register: async (registerData) => {
    const response = await customAxios.post(`${AUTH_BASE_API_URL}/create-user`, registerData);
    return response.data;
  },
};
export default AuthService;
