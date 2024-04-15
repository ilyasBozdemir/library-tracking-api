import { Box, Flex } from "@chakra-ui/react";
import Head from "next/head";
import React, { useState } from "react";

import Navbar from "../components/Admin/Navbar";
import Sidebar from "../components/Admin/Sidebar";

function AdminLayout({ children }) {
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  const toggleSidebar = () => {
    setIsSidebarOpen(!isSidebarOpen);
  };
  return (
    <Flex as="main"  zIndex="1">
      <Head>
        <meta name="robots" content="noindex, nofollow" />
        <link rel="icon" href="/favicon.ico" />
        <title>Library Managament</title>
      </Head>

      <Sidebar isOpen={isSidebarOpen} toggleSidebar={toggleSidebar} />
      <Box w="100%" >
        <Navbar
          onMenuToggle={toggleSidebar}
          isOpen={isSidebarOpen}
          transition="0.3s ease-in-out"
        />
        <Flex direction={{ base: "column", md: "row" }}>
          
          <Box
            flex={1}
            ml={isSidebarOpen ? "350px" : "0px"}
            transition="margin-left 0.5s ease-in-out"
          >
            <Box  p={{ base: 5, md: 10 }}>
              {children}
            </Box>
          </Box>
        </Flex>
      </Box>
    </Flex>
  );
}

export default AdminLayout;
