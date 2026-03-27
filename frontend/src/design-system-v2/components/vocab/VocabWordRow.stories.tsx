import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import TableCell from '@mui/material/TableCell';
import VocabWordRow from './VocabWordRow';

const meta = {
  title: 'Design System/Vocab/VocabWordRow',
  component: VocabWordRow,
  args: {
    word: {
      id: '1',
      greek: 'λόγος',
      transliteration: 'logos',
      definition: 'word, message',
      partOfSpeech: 'Noun',
      frequency: 330,
      srsStatus: 'due',
    },
    onClick: () => {},
  },
} satisfies Meta<typeof VocabWordRow>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: (args) => (
    <Table size="small">
      <TableHead>
        <TableRow>
          <TableCell>Greek</TableCell>
          <TableCell>Transliteration</TableCell>
          <TableCell>Definition</TableCell>
          <TableCell>POS</TableCell>
          <TableCell align="right">Freq</TableCell>
          <TableCell>Status</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        <VocabWordRow {...args} />
      </TableBody>
    </Table>
  ),
};
