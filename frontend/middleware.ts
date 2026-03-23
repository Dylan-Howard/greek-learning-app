import { clerkMiddleware, createRouteMatcher } from '@clerk/nextjs/server';
import { NextResponse } from 'next/server';

const isPublicRoute = createRouteMatcher([
  '/(public)(.*)',
  '/onboarding',
]);

const isProtectedRoute = createRouteMatcher([
  '/(auth)(.*)',
]);

const SIGN_IN_URL = process.env.NEXT_PUBLIC_CLERK_SIGN_IN_URL ?? '/auth/login';

/**
 * Pure helper that resolves the middleware action for a given request context.
 * Extracted for testability — no Next.js request/response cycle needed.
 */
export function resolveMiddlewareAction(
  isPublic: boolean,
  isProtected: boolean,
  userId: string | null,
  pathname: string,
  onboardingComplete: boolean | undefined
): 'next' | 'redirect-signin' | 'redirect-reader' | 'redirect-onboarding' {
  // Authenticated users visiting login/signup → redirect to /reader
  if (userId && (pathname === '/auth/login' || pathname === '/auth/signup')) {
    return 'redirect-reader';
  }

  // Public routes always pass through
  if (isPublic) {
    return 'next';
  }

  // Protected routes: unauthenticated → redirect to sign-in
  if (isProtected && !userId) {
    return 'redirect-signin';
  }

  // Protected routes: authenticated but onboarding not complete → redirect to /onboarding
  if (isProtected && userId && !onboardingComplete) {
    return 'redirect-onboarding';
  }

  return 'next';
}

const middleware = clerkMiddleware(async (auth, req) => {
  const { userId, sessionClaims } = await auth();
  const { pathname } = req.nextUrl;

  const onboardingComplete =
    (sessionClaims?.publicMetadata as Record<string, unknown> | undefined)
      ?.onboardingComplete as boolean | undefined;

  const action = resolveMiddlewareAction(
    isPublicRoute(req),
    isProtectedRoute(req),
    userId,
    pathname,
    onboardingComplete
  );

  if (action === 'redirect-signin') {
    const signInUrl = new URL(SIGN_IN_URL, req.url);
    signInUrl.searchParams.set('redirect_url', req.url);
    return NextResponse.redirect(signInUrl);
  }

  if (action === 'redirect-reader') {
    return NextResponse.redirect(new URL('/reader', req.url));
  }

  if (action === 'redirect-onboarding') {
    return NextResponse.redirect(new URL('/onboarding', req.url));
  }

  return NextResponse.next();
});

export default middleware;

export const config = {
  matcher: [
    /*
     * Match all request paths except:
     * - _next/static (static files)
     * - _next/image (image optimization files)
     * - favicon.ico
     * - public folder files
     */
    '/((?!_next/static|_next/image|favicon\\.ico).*)',
  ],
};
