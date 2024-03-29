#include "nearest_neighbor_brute_force.h"
#include <limits>// std::numeric_limits<double>::infinity();

void nearest_neighbor_brute_force(
  const Eigen::MatrixXd & points,
  const Eigen::RowVector3d & query,
  int & I,
  double & sqrD)
{
  ////////////////////////////////////////////////////////////////////////////
  // Replace with your code here:
  I = -1;
  sqrD = std::numeric_limits<double>::infinity();
  
  double tempSqrD;
  for(int i = 0; i < points.rows(); i++){
    tempSqrD = (points.row(i) - query).squaredNorm();
    if(tempSqrD < sqrD){
      sqrD = tempSqrD;
      I = i;
    }
  }
  ////////////////////////////////////////////////////////////////////////////
}
