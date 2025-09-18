[![](https://img.shields.io/nuget/v/soenneker.quark.fields.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.fields/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.fields/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.fields/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.fields.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.fields/)
[![](https://img.shields.io/badge/Demo-Live-blueviolet?style=for-the-badge&logo=github)](https://soenneker.github.io/soenneker.quark.fields/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Quark.Fields
### A series of Blazor Quark components for form field layouts and structure.

## Installation

```
dotnet add package Soenneker.Quark.Fields
```

## Components

### Field
A layout/structural component that groups a label, input, and optional help/validation messages together in a consistent way. Often used for form rows where you want a label on top/side and the input underneath, styled according to the CSS framework.

### FieldLabel
A label component that can be associated with form inputs. Supports required indicators and horizontal layout modes.

### FieldBody
A container component for input elements when using horizontal field layouts.

### FieldHelp
A component for displaying help text below form inputs.

## Usage

### Basic Field Layout
```razor
<Field>
    <FieldLabel For="textInput">Text Input</FieldLabel>
    <input type="text" id="textInput" class="form-control" placeholder="Enter text..." />
    <FieldHelp>This is help text for the text input field.</FieldHelp>
</Field>
```

### Horizontal Field Layout
```razor
<Field Horizontal="true">
    <FieldLabel For="emailInput" RequiredIndicator="true">Email Address</FieldLabel>
    <FieldBody>
        <input type="email" id="emailInput" class="form-control" placeholder="Enter email..." />
        <FieldHelp>We'll never share your email with anyone else.</FieldHelp>
    </FieldBody>
</Field>
```

### Form Example
```razor
<form>
    <Field>
        <FieldLabel For="firstName" RequiredIndicator="true">First Name</FieldLabel>
        <input type="text" id="firstName" class="form-control" placeholder="Enter your first name" />
    </Field>
    
    <Field Horizontal="true">
        <FieldLabel For="newsletter">Newsletter</FieldLabel>
        <FieldBody>
            <div class="form-check">
                <input type="checkbox" id="newsletter" class="form-check-input" />
                <label for="newsletter" class="form-check-label">Subscribe to our newsletter</label>
            </div>
            <FieldHelp>Get updates about new products and special offers.</FieldHelp>
        </FieldBody>
    </Field>
</form>
```

## Features

- **Layout Support**: Both vertical and horizontal field layouts
- **Required Indicators**: Visual indicators for required fields
- **Help Text**: Consistent styling for help text
- **Bootstrap 5 Compatible**: Uses Bootstrap 5 CSS classes for consistent styling
- **Quark Components**: Built using Quark.Divs, Quark.Labels, and Quark.Spans for consistency
- **Built-in Styling**: Components include default spacing and styling that can be overridden
- **Accessibility**: Proper label associations and semantic HTML structure

## CSS Classes and Default Styling

The components use Bootstrap 5 CSS classes with built-in default styling:

- **Field**: `form-group` (base), `row` (horizontal)
  - Default: `margin-bottom: 1.5rem`
  - Horizontal: `display: flex; align-items: flex-start; gap: 1rem`
- **FieldLabel**: `form-label` (base), `col-form-label` (horizontal)
  - Default: `margin-bottom: 0.5rem; font-weight: 500`
  - Horizontal: `padding-top: calc(0.375rem + 1px); padding-bottom: calc(0.375rem + 1px); margin-bottom: 0; font-weight: 500`
- **FieldBody**: No classes (Bootstrap 5 doesn't require them)
- **FieldHelp**: `form-text text-muted`
  - Default: `margin-top: 0.25rem; font-size: 0.875em`

All default styling can be overridden by passing custom `Style` or `Class` parameters to the components.
