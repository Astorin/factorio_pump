if mods["ModuleInserter"] then

    data:extend({
        {
            type = "bool-setting",
            name = "pump-interface-with-module-inserter-mod",
            setting_type = "runtime-per-user",
            default_value = true
        }
    })
end

data:extend({
    {
        type = "bool-setting",
        name = "pump-ignore-research",
        setting_type = "runtime-per-user",
        default_value = false
    },
    {
        type = "bool-setting",
        name = "pump-always-show",
        setting_type = "runtime-per-user",
        default_value = true
    },
    {
        type = "string-setting",
        name = "pump-selection-tool-keybind",
        setting_type = "runtime-per-user",
        default_value = "CONTROL + SHIFT+ P"
    },
})