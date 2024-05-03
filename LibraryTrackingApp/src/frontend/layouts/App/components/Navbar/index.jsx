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
} from "@chakra-ui/react";
import Link from "next/link";
import ThemeSwitcher from "../../../../components/ThemeSwitcher";
import LanguageSwitcher from "../../../../components/LanguageSwitcher";

import { FiMinimize, FiMaximize, FiBell } from "react-icons/fi";
import { HiMenuAlt2 } from "react-icons/hi";
import { CloseIcon } from "@chakra-ui/icons";

const Navbar = ({ isOpen, onMenuToggle }) => {
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

  return (
    <Flex
      boxShadow="sm"
      border="0 solid #e5e7eb"
      bg={useColorModeValue("gray.100", "gray.700")}
      justifyContent={"space-between"}
      p={2}
      zIndex={15}
      width={isOpen ? "calc(100% - 275px)" : "100%"}
      transform={isOpen ? "translateX(275px)" : "translateX(0)"}
      transition="0.3s ease-in"

    >
      <HStack spacing={3}>
        {isOpen ? (
          <CloseIcon
            boxSize={4}
            cursor={"pointer"}
            onClick={onMenuToggle}
            _hover={{ color: "red" }}
          />
        ) : (
          <Icon
            cursor={"pointer"}
            as={HiMenuAlt2}
            boxSize={18}
            onClick={onMenuToggle}
          />
        )}
      </HStack>
      <Box >
        <NavItem
          isMaximized={isMaximized}
          handleMaximizeToggle={handleMaximizeToggle}
        />
      </Box>
    </Flex>
  );
};

const NavItem = ({ isMaximized, handleMaximizeToggle }) => {
  return (
    <>
      <HStack spacing={3}>
      <NotificationMenu/>
        <LanguageSwitcher />
        <ThemeSwitcher />

        <Icon
          cursor={"pointer"}
          as={isMaximized ? FiMinimize : FiMaximize}
          boxSize={15}
          onClick={handleMaximizeToggle}
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
            <Link href="/app/profile" passHref>
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
      content: "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
      time: "1 saat önce",
      read: true,
    },
    {
      id: 3,
      title: "Bilgilendirme",
      content: "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
      time: "1 gün önce",
      read: false,
    },
  ];

  const handleToggle = () => {
    setIsOpen(!isOpen);
  };

  const { colorMode } = useColorMode();

  // Okunmamış bildirim sayısını hesapla
  const unreadNotificationsCount = notifications.filter(notification => !notification.read).length;

  return (
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
  );
};
export default Navbar;
