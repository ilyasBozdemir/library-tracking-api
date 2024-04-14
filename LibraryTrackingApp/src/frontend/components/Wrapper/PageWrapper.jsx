import { Box,  Flex } from "@chakra-ui/react";
import React from "react";
import { appUser } from "@/constants/appUser";
import { DefaultSeo } from "next-seo";
import PagesCTA from "../PagesCTA";

function PageWrapper({
  children,
  currentPage,
  isDynamicPage = false,
  isCtaShow = true,
}) {
  const currentPageInfo = appUser.pageNames.find(
    (page) => page.title === currentPage
  );

  const { title, description, canonical } =
    appUser.pages[currentPageInfo?.pageName];

  const _SEO = {
    title,
    description,
    canonical: appUser.siteInfo.baseUrl + canonical,
    images: {
      url: appUser.siteInfo.logoUrl,
      alt: description,
    },
  };

  return (
    <Box maxW={"full"} my={3}>
      {!isDynamicPage && (
        <>
          <DefaultSeo
            title={_SEO.title}
            description={_SEO.description}
            canonical={_SEO.canonical}
            openGraph={{
              type: "website",
              locale: "tr_TR",
              siteName: appUser.siteInfo.publisher,
              title: _SEO.title,
              description: _SEO.description,
              images: [
                {
                  url: _SEO.images.url,
                  width: 1200,
                  height: 630,
                  alt: "Og Image Alt",
                },
              ],
            }}
          />
          
        </>
      )}

      <Flex direction={"column"} gap={2}>
        {isCtaShow && (
          <>
            <PagesCTA currentPage={currentPage} />
          </>
        )}
        {children}
      </Flex>
    </Box>
  );
}

export default PageWrapper;