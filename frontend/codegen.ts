import type { CodegenConfig } from '@graphql-codegen/cli';

const config: CodegenConfig = {
  schema: process.env.NEXT_PUBLIC_GRAPHQL_URL ?? 'http://localhost:5001/graphql',
  documents: ['src/lib/api/graphql/**/*.graphql'],
  generates: {
    'src/lib/api/graphql/generated/index.ts': {
      plugins: [
        'typescript',
        'typescript-operations',
        'typescript-react-apollo',
      ],
      config: {
        withHooks: true,
        withResultType: true,
        scalars: {
          UUID: 'string',
          DateTime: 'string',
          DateOnly: 'string',
        },
        nonOptionalTypename: false,
      },
    },
  },
};

export default config;
