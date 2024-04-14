import {
  Stack,
  HStack,
  Link as CLink,
  Divider,
  Image,
  IconButton,
  GridItem,
} from "@chakra-ui/react";
// Here we have used react-icons package for the icons
import { FaGithub, FaLinkedin, FaTwitter } from "react-icons/fa";

import Logo from "./Logo";
import Link from "next/link";

import React from "react";
import { useAppContext } from "@/contexts/AppContext";
import { useTranslation } from "next-i18next";
import SocialButton from "./SocialButton";

let color = {
  light: {
    primary: "#1d2e3d",
    secondary: "#fff",
  },
  dark: {
    primary: "#354656",
    secondary: "#fff",
  },
};

const FooterSection = () => {
  const { footerLinks, socialMediaLinks } = useAppContext();
  const { t } = useTranslation();

  return (
    <>
      <Stack
        maxW="5xl"
        marginInline="auto"
        p={8}
        spacing={{ base: 8, md: 0 }}
        justifyContent="space-between"
        alignItems="center"
        direction={{ base: "column", md: "row" }}
      >
        <Logo />

        {/* Desktop Screen */}
        <HStack spacing={4} alignItems="center">
          {footerLinks.map((link, index) => (
            <CustomLink key={index}>{t(link.i18nKey)}</CustomLink>
          ))}
        </HStack>

        <Stack
          direction="row"
          spacing={5}
          pt={{ base: 4, md: 0 }}
          alignItems="center"
        >
          {socialMediaLinks.map((sc, index) => (
            <GridItem key={sc}>
              <SocialButton label={sc.text} href={sc.path}>
                <sc.icon />
              </SocialButton>
            </GridItem>
          ))}
        </Stack>
      </Stack>
    </>
  );
};

const CustomLink = ({ children, ...props }) => {
  return (
    <CLink
      href="#"
      fontSize="sm"
      _hover={{ textDecoration: "underline" }}
      {...props}
    >
      {children}
    </CLink>
  );
};

const FooterData = () => {
  const startYear = 2023;
  const currentYear = new Date().getFullYear();
  let yearText;
  if (currentYear > startYear) {
    yearText = `${startYear}-${currentYear}`;
  } else {
    yearText = `${startYear}`;
  }
  return <> {yearText} &copy; Tüm Hakları Saklıdır.</>;
};
export async function getStaticProps({ locale }) {
  return {
    props: {
      ...(await serverSideTranslations(locale, ["common"])),
    },
  };
}

export default React.memo(FooterSection);
