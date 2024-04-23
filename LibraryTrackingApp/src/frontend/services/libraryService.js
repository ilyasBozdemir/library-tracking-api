import customAxios from "@/utils/customAxios";

const LIBRARY_BASE_API_URL = `/api/v1/libraries`;

const LibraryService = {
  createLibrary: async (libraryData) => {
    try {
      const response = await customAxios.post(LIBRARY_BASE_API_URL, libraryData);
      return response.data;
    } catch (error) {
      console.error("createLibrary error:", error); // Hata konsola yazıldı
      return Promise.reject(error);
    }
  },
  updateLibraryById: async (id, libraryData) => {
    try {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.put(url, libraryData);
      return response.data;
    } catch (error) {
      console.error("updateLibraryById error:", error); // Hata konsola yazıldı
      return Promise.reject(error);
    }
  },
  deleteLibraryById: async (id) => {
    try {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.delete(url);
      return response.data;
    } catch (error) {
      console.error("deleteLibraryById error:", error); // Hata konsola yazıldı
      return Promise.reject(error);
    }
  },
  getLibraryById: async (id) => {
    try {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.get(url);
      return response.data;
    } catch (error) {
      console.error("getLibraryById error:", error); // Hata konsola yazıldı
      return Promise.reject(error);
    }
  },
  getLibraries: async () => {
    try {
      const response = await customAxios.get(LIBRARY_BASE_API_URL);
      return response.data;
    } catch (error) {
      console.error("getLibraries error:", error); // Hata konsola yazıldı
      return Promise.reject(error);
    }
  },
};

export default LibraryService;
