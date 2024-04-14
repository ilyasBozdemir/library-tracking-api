import { RedocStandalone } from "redoc";
import { useState, useEffect } from "react";
import Head from "next/head";

function ApiDocsPage() {
  const pageTitle = `Kütüphane Takip Uygulaması`;

  return (
    <>
      <Head>
        <title>{pageTitle}</title>
      </Head>
      <RedocStandalone
        specUrl={"https://localhost:7115/swagger/v1/swagger.json"}
        options={{
            theme: { colors: { primary: { main: '#ff0000' } } },
            hideDownloadButton: true,
            hideLoading: true,
          }}
      />
    </>
  );
}

export default ApiDocsPage;
