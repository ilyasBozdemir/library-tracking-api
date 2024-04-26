import React from "react";
import Navbar from "./components/Navbar";
import { tourSteps } from "./guides/tourSteps";
import TourComponent from "@/components/TourComponent";

function Layout({ children }) {
  return (
    <>
      <TourComponent tourSteps={tourSteps} layoutName="mainLayout" />
      <Navbar />
      {children}
    </>
  );
}

export default Layout;
