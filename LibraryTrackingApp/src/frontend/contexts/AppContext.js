import React, { createContext, useContext, useState } from "react";
import initialSiteInfo, {
  footerData,
  navLinks,
  dropdownLinks,
  footerLinks,
  socialMediaLinks,
} from "./appContextValues";
const AppContext = createContext();

export const useAppContext = () => {
  return useContext(AppContext);
};

export const AppContextProvider = ({ children }) => {
  const [analytics, setAnalytics] = useState({
    FacebookPixel: { isActive: true, code: "" },
    GoogleAnalytics: { isActive: true, code: "" },
    LinkedInInsightTag: { isActive: true, code: "" },
    GoogleTagManager: { isActive: true, code: "" },
    TiktokPixel: { isActive: true, code: "" },
    TwitterPixel: { isActive: true, code: "" },
  });

  const toggleAnalytics = (name) => {
    setAnalytics((prevState) => ({
      ...prevState,
      [name]: {
        ...prevState[name],
        isActive: !prevState[name].isActive,
      },
    }));
  };

  const updateCode = (name, newCode) => {
    setAnalytics((prevState) => ({
      ...prevState,
      [name]: {
        ...prevState[name],
        code: newCode,
      },
    }));
  };

  const [adminAnalytics, setAdminAnalytics] = useState({
    FacebookPixel: { isActive: true, code: "" },
    GoogleAnalytics: { isActive: true, code: "" },
    LinkedInInsightTag: { isActive: true, code: "" },
    GoogleTagManager: { isActive: true, code: "" },
    TiktokPixel: { isActive: true, code: "" },
    TwitterPixel: { isActive: true, code: "" },
  });

  const toggleAdminAnalytics = (name) => {
    setAdminAnalytics((prevState) => ({
      ...prevState,
      [name]: {
        ...prevState[name],
        isActive: !prevState[name].isActive,
      },
    }));
  };

  const updateAdminCode = (name, newCode) => {
    setAdminAnalytics((prevState) => ({
      ...prevState,
      [name]: {
        ...prevState[name],
        code: newCode,
      },
    }));
  };

  const siteInfo = initialSiteInfo;

  const contextValue = {
    navLinks,
    dropdownLinks,
    footerLinks,
    footerData,
    siteInfo,
    socialMediaLinks,
    analytics,
    setAnalytics,
    adminAnalytics,
    setAdminAnalytics,
    toggleAnalytics,
    updateCode,
    toggleAdminAnalytics,
    updateAdminCode,
  };
  return (
    <AppContext.Provider value={contextValue}>{children}</AppContext.Provider>
  );
};

export const useApp = () => useContext(AppContext);
