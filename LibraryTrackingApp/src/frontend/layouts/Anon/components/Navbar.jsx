import {
  Box,
  Flex,
  HStack,
  Button,
  Text,
  Link,
  MenuItem,
  Stack,
  IconButton,
  useDisclosure,
  useColorModeValue,
} from "@chakra-ui/react";
// Here we have used react-icons package for the icons
import { GiHamburgerMenu } from "react-icons/gi";
import { AiOutlineClose } from "react-icons/ai";
import ThemeSwitcher from "@/components/ThemeSwitcher";

const navLinks = [
  { name: "Hakkımızda", path: "#" },
  { name: "Özellikler", path: "#" },
  { name: "Blog", path: "#" },
];

export default function Navbar() {
  const { isOpen, onOpen, onClose } = useDisclosure();

  return (
    <Box px={4} bg={useColorModeValue("white", "gray.800")}>
      <Flex h={16} alignItems="center" justifyContent="space-between" mx="auto">
        <Text fontWeight={"semibold"}>LOGO</Text>

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
          </HStack>
        </HStack>

        <Flex
          gap={3}
          textAlign="center"
          display={{ base: "none", md: "inherit" }}
        >
             <ThemeSwitcher />

          <Link href="/register" passHref target="_blank">
            <Button colorScheme="white" variant="outline">
              Kayıt Ol
            </Button>
          </Link>

          <Link href="/login" passHref target="_blank">
            <Button colorScheme="teal">Giriş Yap</Button>
          </Link>
        </Flex>

        <IconButton
          size="md"
          icon={isOpen ? <AiOutlineClose /> : <GiHamburgerMenu />}
          aria-label="Open Menu"
          display={{ base: "inherit", md: "none" }}
          onClick={isOpen ? onClose : onOpen}
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

const NavLink = ({ name, path, onClose }) => {
  return (
    <Link
      href={path}
      lineHeight="inherit"
      _hover={{
        textDecoration: "none",
        color: useColorModeValue("teal.500", "teal.200"),
      }}
      onClick={() => onClose()}
    >
      {name}
    </Link>
  );
};
