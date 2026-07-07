# Contributing Guide

Thank you for contributing to this repository.

## Branching

- Do not push directly to `main`.
- Create a feature branch from `main`:
  - `git checkout main`
  - `git pull origin main`
  - `git checkout -b feat/your-change`

## Pull Request Flow

- Push your branch:
  - `git push -u origin feat/your-change`
- Open a Pull Request to `main`.
- Ensure CI passes.
- Request human review and Copilot review.

## Copilot Review

- This repository is configured to auto-request `copilot` reviewer when a PR is opened and is not draft.
- If `copilot` does not appear in Reviewers:
  - verify Copilot code review is enabled in repository/account settings
  - make sure the PR is not in Draft state

## Commit Message Convention

- Use clear commit messages:
  - `feat: add ...`
  - `fix: resolve ...`
  - `chore: update ...`

## Before Merge

- Resolve review comments.
- Keep branch up to date with `main`.
- Merge only when required checks are green.
