import Error400 from "@/layouts/Placeholder/components/Error400";
import Error401 from "@/layouts/Placeholder/components/Error401";
import Error402 from "@/layouts/Placeholder/components/Error402";
import Error403 from "@/layouts/Placeholder/components/Error403";
import Error404 from "@/layouts/Placeholder/components/Error404";
import Error405 from "@/layouts/Placeholder/components/Error405";
import Error409 from "@/layouts/Placeholder/components/Error409";
import Error500 from "@/layouts/Placeholder/components/Error500";
import Error501 from "@/layouts/Placeholder/components/Error501";
import Error502 from "@/layouts/Placeholder/components/Error502";
import Error503 from "@/layouts/Placeholder/components/Error503";

export const errorStatusCodes = [
  400, 401, 402, 403, 404, 405, 409, 500, 501, 502, 503,
];

export const ErrorComponents = {
  400: Error400,
  401: Error401,
  402: Error402,
  403: Error403,
  404: Error404,
  405: Error405,
  409: Error409,
  500: Error500,
  501: Error501,
  502: Error502,
  503: Error503,
};
