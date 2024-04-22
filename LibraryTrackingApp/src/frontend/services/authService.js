import customAxios from "@/utils/customAxios";
const AUTH_BASE_API_URL = `/api/v1/auths`;

const AuthService = {
  login: async (loginData) => {
    try {
      const response = await customAxios.post(
        `${AUTH_BASE_API_URL}/login`,
        loginData
      );
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  register: async (registerData) => {
    try {
      const response = await customAxios.post(
        `${AUTH_BASE_API_URL}/create-user`,
        registerData
      );
      return response?.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  checkUsernameExists: async (username) => {
    /*
    try {
      const response = await customAxios.post(
        `${AUTH_BASE_API_URL}/check-user-existence`,
        username
      );
      return response?.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  */
    return false;
  },
  checkEmailExists: async (email) => {
    /*
    try {
      const response = await customAxios.post(
        `${AUTH_BASE_API_URL}/check-user-existence`,
        email
      );
      return response?.data;
    } catch (error) {
      return Promise.reject(error);
    }
  */
    return false;
  },
};

export default AuthService;
