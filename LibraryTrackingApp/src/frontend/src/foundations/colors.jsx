/*
   https://aicolors.co/ sitesinden  dark ve light modu için, ordan verilen ;

    --primary-100:#0085ff;
    --primary-200:#69b4ff;
    --primary-300:#e0ffff;
    --accent-100:#006fff;
    --accent-200:#e1ffff;
    --text-100:#FFFFFF;
    --text-200:#9e9e9e;
    --bg-100:#1E1E1E;
    --bg-200:#2d2d2d;
    --bg-300:#454545;
      

    gibi renkleri destekleyn altyapı da kurulcaktır.
*/

// themes.js

export const lightTheme = {
  colors: {
    white: "#ffffff",
    black: "#000000",

    primary: {
      100: "#54BEC3",
      200: "#30a1a6",
      300: "#005f65",
    },
    accent: {
      100: "#c354be",
      200: "#ffecff",
    },
    text: {
      100: "#333333",
      200: "#5c5c5c",
    },
    bg: {
      100: "#F5F5F5",
      200: "#ebebeb",
      300: "#c2c2c2",
    },
  },
};

export const darkTheme = {
  colors: {
    white: "#ffffff",
    black: "#000000",

    primary: {
      100: "#61DAFB",
      200: "#39bcdc",
      300: "#007997",
    },
    accent: {
      100: "#c354be",
      200: "#ffecff",
    },
    text: {
      100: "#FFFFFF",
      200: "#e0e0e0",
    },
    bg: {
      100: "#282C34",
      200: "#383c44",
      300: "#50555e",
    },
  },
};

