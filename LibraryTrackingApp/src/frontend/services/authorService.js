import customAxios from "@/utils/customAxios";

const AUTHOR_BASE_API_URL = `/api/v1/authors`;

const AuthorService = {
  createAuthor: async (authorData) => {
    try {
      const response = await customAxios.post(AUTHOR_BASE_API_URL, authorData);
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  updateAuthorById: async (id, authorData) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await customAxios.put(url, authorData);
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  deleteAuthorById: async (id) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await customAxios.delete(url);
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  getAuthorById: async (id) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await customAxios.get(url);
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
  getAuthors: async () => {
    try {
      const response = await customAxios.get(AUTHOR_BASE_API_URL);
      return response.data;
    } catch (error) {
      // Hata varsa konsola yazma
      return Promise.reject(error);
    }
  },
};

export default AuthorService;
