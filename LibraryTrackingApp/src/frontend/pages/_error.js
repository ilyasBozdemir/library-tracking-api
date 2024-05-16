// pages/_error.js

import { Text } from "@chakra-ui/react";

function NotFoundPage() {
  return (
    <Text textAlign="center" color="red">
      Sayfa bulunamadı.
    </Text>
  );
}

function InternalErrorPage() {
  return (
    <Text textAlign="center" color="red">
      Sunucu iç hatası.
    </Text>
  );
}

function Error({ statusCode }) {
  if (statusCode === 404) {
    return <NotFoundPage />;
  }
  return <InternalErrorPage />;
}

Error.getInitialProps = ({ res, err }) => {
  const statusCode = res ? res.statusCode : err ? err.statusCode : 404;
  return { statusCode };
};

export default Error;
