import React, { useState } from "react";
import { Document, Page, pdfjs } from "react-pdf";
import { Box, Button } from "@chakra-ui/react";
import { site } from "@/constants/site";
import Head from "next/head";

pdfjs.GlobalWorkerOptions.workerSrc = `//cdnjs.cloudflare.com/ajax/libs/pdf.js/${pdfjs.version}/pdf.worker.js`;

const PdfViewer = ({ pdfUrl }) => {
  const [numPages, setNumPages] = useState(null);
  const [pageNumber, setPageNumber] = useState(1);

  const onDocumentLoadSuccess = ({ numPages }) => {
    setNumPages(numPages);
  };

  const goToPrevPage = () => {
    if (pageNumber > 1) {
      setPageNumber(pageNumber - 1);
    }
  };

  const goToNextPage = () => {
    if (pageNumber < numPages) {
      setPageNumber(pageNumber + 1);
    }
  };

  return (
    <>
    <Head>
      <title>
        Dummy Fake E-Book
      </title>
    </Head>
      <Document file={pdfUrl} onLoadSuccess={onDocumentLoadSuccess}>
        <Page pageNumber={pageNumber} />
      </Document>
      <Box textAlign="center">
        <Button
          colorScheme={"teal"}
          onClick={goToPrevPage}
          disabled={pageNumber <= 1}
        >
          Önceki Sayfa
        </Button>
        <span style={{ margin: "0 10px" }}>
          Sayfa {pageNumber} / {numPages}
        </span>
        <Button
          colorScheme={"teal"}
          onClick={goToNextPage}
          disabled={pageNumber >= numPages}
        >
          Sonraki Sayfa
        </Button>
      </Box>
    </>
  );
};

export async function getServerSideProps() {
  //dummy pdf url
  const pdfUrl = site.baseUrl + "/api/pdf-dummy";

  return {
    props: {
      pdfUrl,
    },
  };
}

export default PdfViewer;
