import React, { useState } from "react";
import { RedocStandalone } from "redoc";
import Head from "next/head";
import { site } from "@/constants/site";
import axios from "axios";
import { Flex, Text } from "@chakra-ui/react";
import https from "https";

function DocsPage({ swaggerJsonUri, pageTitle, error }) {
  return (
    <>
      <Head>
        <title>{pageTitle}</title>
      </Head>
      {error ? (
        <Text textAlign={"center"} color={"red"}>
          Sunucu ile bağlantı kurulamadı: {error}
        </Text>
      ) : swaggerJsonUri ? (
        <RedocStandalone
          specUrl={swaggerJsonUri}
          options={{
            theme: { colors: { primary: { main: "#3432a8" } } },
          }}
        />
      ) : (
        <p>Yükleniyor...</p>
      )}
    </>
  );
}

export async function getStaticProps() {
  try {
    const axiosInstance = axios.create({
      baseURL: site.API_BASE_URL,
      httpsAgent: new https.Agent({
        rejectUnauthorized: false, //Self-signed certificate için güvenmesi için ayar
      }),
    });

    const response = await axiosInstance.get(`/api/versions/api-docs`);
    const webAPI = response.data.swaggerJsonUri.webAPI;
    const title = response.data.title;
    return {
      props: {
        swaggerJsonUri: webAPI,
        pageTitle: title,
      },
      revalidate: 3600,
    };
  } catch (error) {
    return {
      props: {
        error: error.message,
      },
    };
  }
}

export default DocsPage;
