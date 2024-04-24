import React from "react";

function GoogleOptimize({ containerID }) {
  return (
    <>
      <script
        src={`https://www.googleoptimize.com/optimize.js?id=${containerID}`}
        async
      />
    </>
  );
}

export default GoogleOptimize;
