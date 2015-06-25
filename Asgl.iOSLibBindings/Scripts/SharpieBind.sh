#!/bin/sh

SDK="iphoneos8.3"
API="unified" # can be "unified" as well

if [ ! -f "Asgl.iOSLibBindings.csproj" ];then
	echo "You must run this script from iOS Binding Project directory";
	exit 1
fi

POD="$1"
if [ "$POD" = "" ]; then
	echo "You must give name of Pod to generate sharpie bindings for"
	exit 1
fi

OUTPUT_DIR="${POD}"
if [ -d $OUTPUT_DIR ]; then
	OUTPUT_DIR="${POD}_${RANDOM}"
	echo "WARNING: $POD output directory exists, using $OUTPUT_DIR instead"
fi

IOSLIB_DIR="${PWD}/../Xcode"
POD_DIR="${IOSLIB_DIR}/Pods"
if [ ! -d "$POD_DIR" ]; then
	echo "No Pods directory under ${IOSLIB_DIR}: You must run pod update"
	exit 1
fi

if [ ! -d "${POD_DIR}/${POD}" ]; then
	echo "$POD does not exist"
	exit 1
fi

EXTRA_ARGS="$2"
echo EXTRA_ARGS
if [ "$EXTRA_ARGS" = "inc_priv" ]; then
	echo "Including private headers"
	POD_PRIVATE_HEADERS=${POD_DIR}/Headers/Private/${POD}/*
	echo "Private headers:" ${POD_PRIVATE_HEADERS}
elif [ "$EXTRA_ARGS" = "add_headers" ]; then
	shift
	shift
	ADD_HEADERS=$@
	echo "Additional headers:" ${ADD_HEADERS}
elif ["$EXTRA_ARGS" != "" ]; then
	echo "extra args not recognized"
	exit 1
fi

POD_HEADERS="${POD_DIR}/Headers/Public/${POD}"
if [ ! -d "$POD_HEADERS" ]; then
	echo "$POD_HEADERS: Does not exist"
	exit 1
fi


TARGET_FILES="${POD_DIR}/Target Support Files"
IOSLIB_TARGET_FILES="${TARGET_FILES}/Pods-iOSLibs"
if [ ! -d "$IOSLIB_TARGET_FILES" ]; then
	echo "$IOSLIB_TARGET_FILES: Does not exist"
	exit 1
fi

POD_PCH="${TARGET_FILES}/Pods-iOSLibs-${POD}/Pods-iOSLibs-${POD}-prefix.pch"
if [ ! -f "$POD_PCH" ]; then
	echo "$POD_PCH: Does not exist"
	exit 1
fi

ls ${POD_HEADERS}
#-I"${IOSLIB_TARGET_FILES}" -I"${POD_HEADERS}" -scope "$IOSLIB_TARGET_FILES" -scope ${POD_HEADERS} -${API} ${POD_HEADERS}/*
sharpie bind -o ${OUTPUT_DIR} -n "Asgl.iOSLibBindings.${POD}" -sdk ${SDK}  ${POD_HEADERS}/* ${POD_PRIVATE_HEADERS} ${ADD_HEADERS} -c -I"${IOSLIB_TARGET_FILES}" -I${POD_HEADERS} -include "${POD_PCH}"

echo "--------"
echo "Binding complete. Check directory \"$OUTPUT_DIR\" for results and import into Xamarin"
