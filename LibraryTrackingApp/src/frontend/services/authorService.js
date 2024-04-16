import { site } from "@/constants/site";
import axios from "axios";

const AUTHOR_BASE_API_URL = `${site.API_BASE_URL}/api/v1/authors`;

const AuthorService = {
  createAuthor: async (authorData) => {
    const response = await fetch(AUTHOR_BASE_API_URL, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: authorData,
    });
    return response.json();
  },
  updateAuthorById: async (id, authorData) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await axios.put(url, authorData);
      return response.data;
    } catch (error) {
      console.error("Yazar güncelleme hatası:", error);
      return error;
    }
  },
  deleteAuthorById: async (id) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await axios.delete(url);
      return response.data;
    } catch (error) {
      console.error("Yazar silme hatası:", error);
      return error;
    }
  },
  getAuthorById: async (id) => {
    try {
      var url = `${AUTHOR_BASE_API_URL}/${id}`;
      const response = await axios.get(url);
      return response.data;
    } catch (error) {
      console.error("Yazar getirme hatası:", error);
      return error;
    }
  },
  getAuthors: async () => {
    try {
      const response = await axios.get(AUTHOR_BASE_API_URL);
      return response.data;
    } catch (error) {
      console.error("Yazar getirme hatası:", error);
      return error;
    }
  },
};

export default AuthorService;
