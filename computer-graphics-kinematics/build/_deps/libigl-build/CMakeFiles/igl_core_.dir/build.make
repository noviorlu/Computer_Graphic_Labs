# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.16

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/noviorlu/Desktop/computer-graphics-kinematics

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/noviorlu/Desktop/computer-graphics-kinematics/build

# Utility rule file for igl_core_.

# Include the progress variables for this target.
include _deps/libigl-build/CMakeFiles/igl_core_.dir/progress.make

igl_core_: _deps/libigl-build/CMakeFiles/igl_core_.dir/build.make

.PHONY : igl_core_

# Rule to build all files generated by this target.
_deps/libigl-build/CMakeFiles/igl_core_.dir/build: igl_core_

.PHONY : _deps/libigl-build/CMakeFiles/igl_core_.dir/build

_deps/libigl-build/CMakeFiles/igl_core_.dir/clean:
	cd /home/noviorlu/Desktop/computer-graphics-kinematics/build/_deps/libigl-build && $(CMAKE_COMMAND) -P CMakeFiles/igl_core_.dir/cmake_clean.cmake
.PHONY : _deps/libigl-build/CMakeFiles/igl_core_.dir/clean

_deps/libigl-build/CMakeFiles/igl_core_.dir/depend:
	cd /home/noviorlu/Desktop/computer-graphics-kinematics/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/noviorlu/Desktop/computer-graphics-kinematics /home/noviorlu/Desktop/computer-graphics-kinematics/build/_deps/libigl-src /home/noviorlu/Desktop/computer-graphics-kinematics/build /home/noviorlu/Desktop/computer-graphics-kinematics/build/_deps/libigl-build /home/noviorlu/Desktop/computer-graphics-kinematics/build/_deps/libigl-build/CMakeFiles/igl_core_.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : _deps/libigl-build/CMakeFiles/igl_core_.dir/depend

