import React, { createContext, useContext } from "react";
import initialSiteInfo, {
  footerData,
  navLinks,
  dropdownLinks,
  footerLinks,
  socialMediaLinks
} from "./appContextValues";

const AppContext = createContext();

export const useAppContext = () => {
  return useContext(AppContext);
};

export const AppContextProvider = ({ children }) => {
  const siteInfo = initialSiteInfo;

  const contextValue = {
    navLinks,
    dropdownLinks,
    footerLinks,
    footerData,
    siteInfo,
    socialMediaLinks
  };
  return (
    <AppContext.Provider value={contextValue}>{children}</AppContext.Provider>
  );
};
