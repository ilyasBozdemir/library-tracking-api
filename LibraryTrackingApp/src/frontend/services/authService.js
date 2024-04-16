import { site } from "@/constants/site";
// düzenlenecek.
const AUTH_BASE_API_URL = `${site.API_BASE_URL}/api/v1/auths`;

const AuthService = {
    login: async (loginData) => {
    const response = await fetch(AUTH_BASE_API_URL, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: (loginData)
    });
    return response.json()
  },
  register : async (registerData) => {
    const response = await fetch(AUTH_BASE_API_URL, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: (registerData)
    });
    return response.json()
  },

};



  export default new AuthService;
  