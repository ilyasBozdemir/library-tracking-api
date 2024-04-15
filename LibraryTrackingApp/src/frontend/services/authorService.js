import { site } from "@/constants/site";

const AUTHOR_BASE_API_URL = `${site.API_BASE_URL}/api/v1/authors`;

const AuthorService = {
  createAuthor: async (authorData) => {
    const response = await fetch(AUTHOR_BASE_API_URL, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: (authorData)
    });
    return response.json()
  },


};

export default AuthorService;
