import { useState } from "react";
import {
  Box,
  Avatar,
  Button,
  HStack,
  VStack,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  Text,
  useColorModeValue,
  Icon,
  Flex,
  useColorMode,
  IconButton,
  Link as CLink,
  useDisclosure,
} from "@chakra-ui/react";
import Link from "next/link";

import { TfiHome } from "react-icons/tfi";
import { FiMinimize, FiMaximize, FiBell } from "react-icons/fi";
import ThemeSwitcher from "@/components/ThemeSwitcher";
import LanguageSwitcher from "@/components/LanguageSwitcher";
import { GiHamburgerMenu } from "react-icons/gi";
import { useRouter } from "next/router";
import { AiOutlineClose } from "react-icons/ai";

const navLinks = [
  { name: "Hakkımızda", path: "/about", target: "_self" },
  { name: "Özellikler", path: "/features", target: "_self" },
  { name: "Dökümantasyon", path: "/docs", target: "_blank" },
  { name: "Topluluk", path: "/community", target: "_self" },
  { name: "Forum", path: "/forum", target: "_self" },
  { name: "Blog", path: "/blog" },
];

const Navbar = () => {
  const [isMaximized, setIsMaximized] = useState(false);

  const handleMaximizeToggle = () => {
    setIsMaximized(!isMaximized);

    if (!isMaximized) {
      // Pencere tam ekran yapılabilir
      if (document.documentElement.requestFullscreen) {
        document.documentElement.requestFullscreen();
      } else if (document.documentElement.mozRequestFullScreen) {
        document.documentElement.mozRequestFullScreen();
      } else if (document.documentElement.webkitRequestFullscreen) {
        document.documentElement.webkitRequestFullscreen();
      } else if (document.documentElement.msRequestFullscreen) {
        document.documentElement.msRequestFullscreen();
      }
    } else {
      // Tam ekranı kapat
      if (document.exitFullscreen) {
        document.exitFullscreen();
      } else if (document.mozCancelFullScreen) {
        document.mozCancelFullScreen();
      } else if (document.webkitExitFullscreen) {
        document.webkitExitFullscreen();
      } else if (document.msExitFullscreen) {
        document.msExitFullscreen();
      }
    }
  };
  const { colorMode } = useColorMode();
  const { isOpen, onOpen, onClose } = useDisclosure();
  return (
    <>
      <Flex
        boxShadow="sm"
        border="0 solid #e5e7eb"
        bg={useColorModeValue("gray.100", "gray.700")}
        justifyContent={"space-between"}
        p={2}
        zIndex={15}
        width={"100%"}
        alignItems="center"
      >
        <IconButton
          size="md"
          icon={isOpen ? <AiOutlineClose /> : <GiHamburgerMenu />}
          aria-label="Open Menu"
          display={{ base: "inherit", md: "none" }}
          onClick={isOpen ? onClose : onOpen}
          variant={"ghost"}
        />
        <Link href="/">
              <Text
                fontWeight={"semibold"}
                fontSize={{ base: 18, md: 20 }}
                line
              >
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
        <Box>
          <NavItem
            isMaximized={isMaximized}
            handleMaximizeToggle={handleMaximizeToggle}
          />
        </Box>
      </Flex>
    </>
  );
};

const NavItem = ({ isMaximized, handleMaximizeToggle }) => {
  const { colorMode } = useColorMode();

  return (
    <>
      <HStack spacing={3}>
        <NotificationMenu />
        <LanguageSwitcher />
        <ThemeSwitcher />

        <Icon
          cursor={"pointer"}
          as={isMaximized ? FiMinimize : FiMaximize}
          boxSize={15}
          onClick={handleMaximizeToggle}
          _hover={{ color: colorMode === "light" ? "teal.500" : "teal.300" }}
        />

        <Menu isLazy>
          <MenuButton as={Button} size="sm" _hover={{ variant: "ghost" }}>
            <Avatar
              size="sm"
              src={"https://avatars.githubusercontent.com/u/52322835?s=96&v=4"}
            />
          </MenuButton>
          <MenuList
            zIndex={5}
            border="2px solid"
            borderColor={useColorModeValue("gray.100", "gray.700")}
            boxShadow="4px 4px 0"
          >
            <Link href="/profile" passHref>
              <MenuItem>
                <VStack justify="start" alignItems="left">
                  <Text fontWeight="500">İlyas Bozdemir</Text>
                  <Text size="sm" color="gray.500" mt="0 !important">
                    @ilyasbozdemir
                  </Text>
                </VStack>
              </MenuItem>
            </Link>
          </MenuList>
        </Menu>
      </HStack>
    </>
  );
};
const NotificationMenu = () => {
  const [isOpen, setIsOpen] = useState(false);
  const notifications = [
    {
      id: 1,
      title: "Yeni Mesaj",
      content: "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
      time: "5 dakika önce",
      read: false,
    },
    {
      id: 2,
      title: "Bildirim",
      content:
        "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
      time: "1 saat önce",
      read: true,
    },
    {
      id: 3,
      title: "Bilgilendirme",
      content:
        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
      time: "1 gün önce",
      read: false,
    },
  ];

  const handleToggle = () => {
    setIsOpen(!isOpen);
  };

  const { colorMode } = useColorMode();

  // Okunmamış bildirim sayısını hesapla
  const unreadNotificationsCount = notifications.filter(
    (notification) => !notification.read
  ).length;

  return (
    <>
      <Menu isLazy>
        <MenuButton
          cursor="pointer"
          boxSize={15}
          _hover={{ color: colorMode === "light" ? "teal.500" : "teal.300" }}
          onClick={handleToggle}
          position="relative"
        >
          <FiBell />
        </MenuButton>
        <MenuList
          zIndex={5}
          border="2px solid"
          borderColor="gray.200"
          boxShadow="4px 4px 0"
          minWidth="200px"
          display={isOpen ? "block" : "none"}
        >
          {notifications.map((notification, index) => (
            <MenuItem key={index}>
              <VStack spacing={2} align="start">
                <Text fontWeight="500">{notification.title}</Text>
                <Text color="gray.500">{notification.content}</Text>
              </VStack>
            </MenuItem>
          ))}
        </MenuList>
      </Menu>
    </>
  );
};
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

export default Navbar;
