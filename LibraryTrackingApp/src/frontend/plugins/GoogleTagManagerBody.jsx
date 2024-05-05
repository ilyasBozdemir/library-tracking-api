import React from "react";

function GoogleTagManagerBody({ code }) {
  return (
    <>
      <noscript>
        <iframe
          src={`https://www.googletagmanager.com/ns.html?id=${code}`}
          height="10"
          width="10"
          style={{ display: "none", visibility: "hidden" }}
        />
      </noscript>
    </>
  );
}

export default GoogleTagManagerBody;
