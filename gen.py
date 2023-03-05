#!/usr/bin/env python3
from jinja2 import Template, Environment, FileSystemLoader
import json
from pathlib import Path
import os

env = Environment(loader=FileSystemLoader('./', encoding='utf8'))
tmpl = env.get_template('class.j2')

def cap(input):
    return "%s%s" % (input[0].upper(), input[1:])

def constraint(input):
    if input['return_type']['name'] == 'T':
        return ' where T : class'
    return ''

def methodReturnType(input):
    return_type = input['return_type']
    type = return_type['type'];
    if type == "void":
        return "void"
    name = return_type['name'];
    if type == 'val':
        if 'boolShortCircuit' in return_type and return_type['boolShortCircuit']:
            return 'bool'
        return name + '?'
    elif type == 'obj':
        return name
    return ''

def isGeneric(input):
    return input['name'].endswith('<T>')


env.filters['cap'] = cap
env.filters['methodReturnType'] = methodReturnType
env.filters['constraint'] = constraint
env.filters['isGeneric'] = isGeneric

files = Path('.').glob('definition/*.json')
for file in files:
    with open(file) as f:
        params = json.load(f)
        class_name = params['class']

        print("Generating " + class_name)
        source = tmpl.render(params)
        source_lines = source.split('\n')
        for i, line in enumerate(source_lines):
            source_lines[i] = line.rstrip()
        source = '\n'.join(source_lines)
        
        text_file = open(os.path.join("lib", class_name + ".cs"), "w")
        text_file.write(source)
        text_file.close()
