import { useState } from "react";
import {
  Container,
  Box,
  Avatar,
  Button,
  HStack,
  VStack,
  Image,
  Input,
  Spacer,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  Text,
  MenuDivider,
  useColorModeValue,
  Icon,
  Flex,
  Stack,
} from "@chakra-ui/react";
import { IoIosNotificationsOutline } from "react-icons/io";
import Link from "next/link";
import ThemeSwitcher from ".././../ThemeSwitcher";
import LanguageSwitcher from ".././../LanguageSwitcher";

import {
  FiMinimize,
  FiMaximize,
  FiMoreHorizontal,
  FiMoreVertical,
} from "react-icons/fi";
import { HiOutlineEnvelope } from "react-icons/hi2";
import { HiMenuAlt2 } from "react-icons/hi";
import { MdOutlineSegment } from "react-icons/md";
import { AiOutlineSetting, AiOutlineSearch } from "react-icons/ai";

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
      py="2"
      boxShadow="sm"
      border="0 solid #e5e7eb"
      position="fixed"
      top="0"
      bg={useColorModeValue("gray.100", "gray.700")}
      width="100%"
      transition="0.3s ease-in-out"
      justifyContent={"space-between"}
      p={2}
    >
      <HStack spacing={3}>
        <Icon
          cursor={"pointer"}
          as={HiMenuAlt2}
          boxSize={18}
          onClick={onMenuToggle}
        />
      </HStack>

      <NavItem
        isMaximized={isMaximized}
        handleMaximizeToggle={handleMaximizeToggle}
      />
    </Flex>
  );
};

const NavItem = ({ isMaximized, handleMaximizeToggle }) => {
  return (
    <>
      <HStack spacing={3}>
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
            <Avatar size="sm" src={"https://avatars.githubusercontent.com/u/52322835?s=96&v=4"} />
          </MenuButton>
          <MenuList
            zIndex={5}
            border="2px solid"
            borderColor={useColorModeValue("gray.700", "gray.100")}
            boxShadow="4px 4px 0"
          >
            <Link href="/admin/profile" passHref>
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

export default Navbar;
