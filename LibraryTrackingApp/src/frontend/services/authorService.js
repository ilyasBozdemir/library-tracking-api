import customAxios from "@/utils/customAxios";

const AUTHOR_BASE_API_URL = `/api/v1/authors`;

const AuthorService = {
  createAuthor: async (authorData) => {
    const response = await customAxios.post(AUTHOR_BASE_API_URL, authorData);
    return response.json();
  },
  updateAuthorById: async (id, authorData) => {
    var url = `${AUTHOR_BASE_API_URL}/${id}`;
    const response = await customAxios.put(url, authorData);
    return response.data;
  },
  deleteAuthorById: async (id) => {
    var url = `${AUTHOR_BASE_API_URL}/${id}`;
    const response = await customAxios.delete(url);
    return response.data;
  },
  getAuthorById: async (id) => {
    var url = `${AUTHOR_BASE_API_URL}/${id}`;
    const response = await customAxios.get(url);
    return response.data;
  },
  getAuthors: async () => {
    const response = await customAxios.get(AUTHOR_BASE_API_URL);
    return response.data;
  },
};

export default AuthorService;
