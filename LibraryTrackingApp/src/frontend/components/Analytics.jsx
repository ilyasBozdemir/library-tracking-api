import { useApp } from "@/contexts/AppContext";
import FacebookPixel from "@/plugins/FacebookPixel";
import GoogleAnalytics from "@/plugins/GoogleAnalytics";
import GoogleTagManager from "@/plugins/GoogleTagManager";
import GoogleTagManagerBody from "@/plugins/GoogleTagManagerBody";
import LinkedInInsightTag from "@/plugins/LinkedInInsightTag";
import TiktokPixel from "@/plugins/TiktokPixel";
import Head from "next/head";
import React from "react";

const Analytics = ({ isAdmin = false }) => {
  const { analytics, adminAnalytics } = useApp();

  const selectedAnalytics = isAdmin ? adminAnalytics : analytics;

  return (
    <>
      <Head>
        {selectedAnalytics.GoogleAnalytics.isActive && (
          <GoogleAnalytics code={selectedAnalytics.GoogleAnalytics.code} />
        )}
        {selectedAnalytics.FacebookPixel.isActive && (
          <FacebookPixel code={selectedAnalytics.FacebookPixel.code} />
        )}
        {selectedAnalytics.GoogleTagManager.isActive && (
          <GoogleTagManager code={selectedAnalytics.GoogleTagManager.code} />
        )}
        {selectedAnalytics.TiktokPixel.isActive && (
          <TiktokPixel code={selectedAnalytics.TiktokPixel.code} />
        )}
        {selectedAnalytics.LinkedInInsightTag.isActive && (
          <LinkedInInsightTag
            code={selectedAnalytics.LinkedInInsightTag.code}
          />
        )}
      </Head>
      <>
        {selectedAnalytics.GoogleAnalytics.isActive && (
          <GoogleTagManagerBody code={selectedAnalytics.GoogleAnalytics.code} />
        )}
      </>
    </>
  );
};

export default Analytics;
