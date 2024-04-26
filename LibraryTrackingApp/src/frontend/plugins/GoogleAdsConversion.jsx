import React from "react";

function GoogleAdsConversion({ conversionID }) {
  return (
    <>
      <script
        dangerouslySetInnerHTML={{
          __html: `
            gtag('event', 'conversion', {
              'send_to': '${conversionID}',
            });
          `,
        }}
      />
    </>
  );
}

export default GoogleAdsConversion;
