import React from "react";

import {
  ErrorComponents,
  errorStatusCodes,
} from "@/constants/errorStatusCodes";

function PlaceholderLayout({ children, statusCode }) {
  if (errorStatusCodes.includes(statusCode)) {
    const ErrorComponent = ErrorComponents[statusCode];
    return <ErrorComponent />;
  }

  return <React.Fragment>{children}</React.Fragment>;
}

export default PlaceholderLayout;
