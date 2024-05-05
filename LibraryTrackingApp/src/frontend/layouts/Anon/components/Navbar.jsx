import {
  Box,
  Flex,
  HStack,
  Button,
  Text,
  MenuItem,
  Stack,
  IconButton,
  useDisclosure,
  useColorModeValue,
  textDecoration,
  Link as CLink,
} from "@chakra-ui/react";
// Here we have used react-icons package for the icons
import { GiHamburgerMenu } from "react-icons/gi";
import { AiOutlineClose } from "react-icons/ai";
import ThemeSwitcher from "@/components/ThemeSwitcher";
import Link from "next/link";
import { useRouter } from "next/router";

const navLinks = [
  { name: "Hakkımızda", path: "/about", target: "_self" },
  { name: "Özellikler", path: "/features", target: "_self" },
  { name: "Dökümantasyon", path: "/docs", target: "_blank" },
  { name: "Forum", path: "/forum", target: "_self" },
  { name: "Blog", path: "/blog" },
];

export default function Navbar() {
  const { isOpen, onOpen, onClose } = useDisclosure();

  return (
    <Box px={10} bg={useColorModeValue("white", "gray.800")}>
      <Flex h={16} alignItems="center" justifyContent="space-between" mx="auto">
        <Link href="/">
          <Text fontWeight={"semibold"} fontSize={{ base: 18, md: 20 }} line>
            LOGO
          </Text>
        </Link>

        <HStack
          as="nav"
          spacing={6}
          display={{ base: "none", md: "flex" }}
          alignItems="center"
        >
          {navLinks.map((link, index) => (
            <NavLink key={index} {...link} onClose={onClose} />
          ))}
        </HStack>
        <Flex
          gap={3}
          textAlign="center"
          display={{ base: "none", md: "inherit" }}
        >
          <ThemeSwitcher />

          <Link href="/register" passHref target="_blank">
            <Button colorScheme="white" variant="outline"
             px={6}

            >
              Kayıt Ol
            </Button>
          </Link>

          <Link href="/login" passHref target="_blank">
            <Button
              bgGradient="linear(to-br, teal.500, teal.300)"
              color="white"
              _hover={{ bgGradient: "linear(to-br, teal.500, teal.400)" }}
              px={6}
            >
              Giriş Yap
            </Button>
          </Link>
        </Flex>

        <IconButton
          size="md"
          icon={isOpen ? <AiOutlineClose /> : <GiHamburgerMenu />}
          aria-label="Open Menu"
          display={{ base: "inherit", md: "none" }}
          onClick={isOpen ? onClose : onOpen}
          variant={"ghost"}
        />
      </Flex>

      {isOpen ? (
        <Box pb={4} display={{ base: "inherit", md: "none" }}>
          <Stack as="nav" spacing={2}>
            {navLinks.map((link, index) => (
              <NavLink key={index} {...link} onClose={onClose} />
            ))}
          </Stack>
        </Box>
      ) : null}
    </Box>
  );
}

const NavLink = ({ name, path, target, onClose }) => {
  const router = useRouter();
  const isActive = router.pathname === path;

  const color = isActive
    ? useColorModeValue("teal.500", "teal.200")
    : useColorModeValue("black", "white");

  return (
    <CLink
      as={Link}
      href={path}
      lineHeight="inherit"
      target={target}
      color={color}
      _hover={{
        textDecoration: "none",
        color: useColorModeValue("teal.500", "teal.200"),
        textDecoration: "underline",
      }}
      onClick={() => onClose()}
    >
      {name}
    </CLink>
  );
};
