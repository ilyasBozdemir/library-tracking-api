import { Box, Icon, useColorMode } from "@chakra-ui/react";
import Link from "next/link";
import React from "react";

function Logo({ from = "header" }) {
  const { colorMode } = useColorMode();

  const colorN = colorMode === "dark" ? "white" : "red";

  return (
    <>
      <Link href="/">
        {from === "footer" ? (
          <>
            <LogoSVG width="100px" height="100px" svgColor={colorN} />
          </>
        ) : (
          <>
            <LogoSVG width={"60px"} height={"50px"} svgColor={colorN} />
          </>
        )}
      </Link>
    </>
  );
}

const LogoSVG = ({ svgColor, width, height }) => {
  return (
    <Icon
      viewBox={`0 0 ${width} ${height}`}
      fill={svgColor}
      width={width}
      height={height}
    >
      <rect
        width="100%"
        height="100%"
        fill={svgColor}
      />

    </Icon>
  );
}




export default Logo;
