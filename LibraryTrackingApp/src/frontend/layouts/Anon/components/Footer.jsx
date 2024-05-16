import {
  Link as CLink,
  Flex,
} from "@chakra-ui/react";
import Link from "next/link";


import React from "react";

const Footer = () => {


  return (
    <Flex justifyContent={'center'}>
    <FooterData/>
    </Flex>
  );
};


const FooterData = () => {
  const startYear = 2024;
  const currentYear = new Date().getFullYear();
  let yearText;
  if (currentYear > startYear) {
    yearText = `${startYear}-${currentYear}`;
  } else {
    yearText = `${startYear}`;
  }
  const utmParameters = '?utm_source=library-tracking-app&utm_medium=footer&utm_campaign=yourcampaign';

  return (
    <>
      <Link href={`https://ilyasbozdemir.dev/${utmParameters}`} target={'_blank'}>
        <>{yearText} İlyas Bozdemir &copy; Tüm Hakları Saklıdır.</>
      </Link>
    </>
  );
};
export async function getStaticProps({ locale }) {
  return {
    props: {
      ...(await serverSideTranslations(locale, ["common"])),
    },
  };
}

export default React.memo(Footer);
