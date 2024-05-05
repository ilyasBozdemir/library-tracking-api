import React from "react";
import Navbar from "./components/Navbar";
import { tourSteps } from "./guides/tourSteps";
import TourComponent from "@/components/TourComponent";
import Footer from "./components/Footer";
import Analytics from "@/components/Analytics";

function Layout({ children }) {
  return (
    <>
      <TourComponent tourSteps={tourSteps} layoutName="mainLayout" />
      <Navbar />
      <Analytics isAdmin={true} />
      {children}
      <Footer/>
    </>
  );
}

export default Layout;
