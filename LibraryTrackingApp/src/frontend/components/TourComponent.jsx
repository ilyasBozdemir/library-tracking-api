import React, { useState, useEffect } from "react";
import LazyReactJoyride from "react-joyride";

const TourComponent = ({ tourSteps, layoutName }) => {
  const [isMounted, setIsMounted] = useState(false);
  const [isTourOpen, setIsTourOpen] = useState(true);

  useEffect(() => {
    setIsMounted(true);

    const hasSeenTour = localStorage.getItem(`hasSeenTour_${layoutName}`);

    if (hasSeenTour) {
      setIsTourOpen(hasSeenTour === "true" ? false : true);
    }
  }, []);

  const handleJoyrideCallback = (data) => {
    if (data.type === "tour:status") {
      localStorage.setItem(`hasSeenTour_${layoutName}`, true);
    }
  };

  return (
    <>
      {isMounted && (
        <LazyReactJoyride
          steps={tourSteps}
          run={isTourOpen}
          continuous={true}
          callback={handleJoyrideCallback}
          showProgress={true}
        />
      )}
    </>
  );
};

export default TourComponent;
