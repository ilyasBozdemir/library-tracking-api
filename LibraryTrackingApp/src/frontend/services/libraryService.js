import customAxios from "@/utils/customAxios";

const LIBRARY_BASE_API_URL = `/api/v1/libraries`;


const LibraryService = {
    createLibrary: async (libraryData) => {
      const response = await customAxios.post(LIBRARY_BASE_API_URL, libraryData);
      return response.json();
    },
    updateLibraryById: async (id, libraryData) => {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.put(url, libraryData);
      return response.data;
    },
    deleteLibraryById: async (id) => {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.delete(url);
      return response.data;
    },
    getLibraryById: async (id) => {
      var url = `${LIBRARY_BASE_API_URL}/${id}`;
      const response = await customAxios.get(url);
      return response.data;
    },
    getLibraries: async () => {
      const response = await customAxios.get(LIBRARY_BASE_API_URL);
      return response.data;
    },
  };


export default LibraryService;