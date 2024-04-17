import React from "react";

import { RedocStandalone } from "redoc";
import Head from "next/head";

function DocsPage() {
  const pageTitle = `Kütüphane Takip Uygulaması`;

  return (
    <>
      <Head>
        <title>{pageTitle}</title>
      </Head>
      <RedocStandalone
        specUrl={"https://localhost:7115/swagger/v1/swagger.json"}
        options={{
          theme: { colors: { primary: { main: "#3432a8" } } },
        }}
      />
    </>
  );
}

export default DocsPage;
