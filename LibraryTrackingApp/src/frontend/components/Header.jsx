import React from "react";
import LangSwitcher from "@/components/LangSwitcher";
import LocaleLink from "./LocaleLink";
import { useTranslation } from "next-i18next";
import {
  Box,
  Flex,
  HStack,
  Button,
  Text,
  Link,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  Stack,
  Icon,
  IconButton,
  useDisclosure,
  useColorModeValue,
} from "@chakra-ui/react";

import { GiHamburgerMenu } from "react-icons/gi";
import { AiOutlineClose } from "react-icons/ai";
import { BiChevronDown } from "react-icons/bi";
import { RiFlashlightFill } from "react-icons/ri";
import ThemeSwitcher from "./ThemeSwitcher";
import { useAppContext } from "@/contexts/AppContext";
import Logo from "./Logo";

export default function Header() {
  const { isOpen, onOpen, onClose } = useDisclosure();

  const { navLinks, dropdownLinks } = useAppContext();
  const { t } = useTranslation();

  return (
    <Box px={4} bg={useColorModeValue("white", "gray.800")} color={'primary'}>
      <Flex h={16} alignItems="center" justifyContent="space-between" mx="auto">
       <Logo/>

        <HStack spacing={8} alignItems="center">
          <HStack
            as="nav"
            spacing={6}
            display={{ base: "none", md: "flex" }}
            alignItems="center"
          >
            {navLinks.map((link, index) => (
              <NavLink key={index} {...link} onClose={onClose} />
            ))}

            {/* Dropdown Menu */}
            <Menu autoSelect={false} isLazy>
              {({ isOpen, onClose }) => (
                <>
                  <MenuButton _hover={{ color: "blue.400" }}>
                    <Flex alignItems="center">
                      <Text>{t("navs.community")}</Text>

                      <Icon
                        as={BiChevronDown}
                        h={5}
                        w={5}
                        ml={1}
                        transition="all .25s ease-in-out"
                        transform={isOpen ? "rotate(180deg)" : ""}
                      />
                    </Flex>
                  </MenuButton>
                  <MenuList
                    zIndex={5}
                    bg={useColorModeValue(
                      "rgb(255, 255, 255)",
                      "rgb(26, 32, 44)"
                    )}
                    border="none"
                    boxShadow={useColorModeValue(
                      "2px 4px 6px 2px rgba(160, 174, 192, 0.6)",
                      "2px 4px 6px 2px rgba(9, 17, 28, 0.6)"
                    )}
                  >
                    {dropdownLinks.map((link, index) => (
                      <MenuLink
                        key={index}
                        name={link.name}
                        path={link.path}
                        onClose={onClose}
                      />
                    ))}
                  </MenuList>
                </>
              )}
            </Menu>
          </HStack>
        </HStack>

        <HStack>
          <ThemeSwitcher />
          <LangSwitcher />
        </HStack>

        <IconButton
          size="md"
          icon={isOpen ? <AiOutlineClose /> : <GiHamburgerMenu />}
          aria-label="Open Menu"
          display={{ base: "initial", md: "none" }}
          onClick={isOpen ? onClose : onOpen}
        />
      </Flex>

      {isOpen ? (
        <Box pb={4} d={{ base: "inherit", md: "none" }}>
          <Stack as="nav" spacing={2}>
            {navLinks.map((link, index) => (
              <NavLink key={index} {...link} onClose={onClose} />
            ))}
            <Text fontWeight="semibold" color="gray.500">
              {t("navs.community")}
            </Text>
            <Stack pl={2} spacing={1} mt={"0 !important"}>
              {dropdownLinks.map((link, index) => (
                <NavLink key={index} {...link} onClose={onClose} />
              ))}
            </Stack>
          </Stack>
        </Box>
      ) : null}
    </Box>
  );
}

const NavLink = ({ name, i18nKey, path, onClose }) => {
  const { t } = useTranslation();
  return (
    <Link
      href={path}
      lineHeight="inherit"
      _hover={{
        textDecoration: "none",
        color: useColorModeValue("blue.500", "blue.200"),
      }}
      onClick={() => onClose()}
    >
      {t(i18nKey)}
    </Link>
  );
};

const MenuLink = ({ name, path, onClose }) => {
  return (
    <Link href={path} onClick={() => onClose()}>
      <MenuItem
        _hover={{
          color: "blue.400",
          bg: useColorModeValue("gray.200", "gray.700"),
        }}
      >
        <Text>{name}</Text>
      </MenuItem>
    </Link>
  );
};

export async function getStaticProps({ locale }) {
  return {
    props: {
      ...(await serverSideTranslations(locale, ["common"])),
    },
  };
}
