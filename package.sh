#!/bin/bash -eux
TMP=$(mktemp -d)
PKG=$PWD/pkg
rm -rf "$PKG"
mkdir -p $TMP/Drift "$PKG"
cp Drift/Info.json Drift/bin/Debug/Drift.dll $TMP/Drift
cd $TMP
zip -r $PKG/Drift.zip Drift
