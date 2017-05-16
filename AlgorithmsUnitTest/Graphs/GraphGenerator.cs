﻿using Algorithms.DataStructures.Graphs;

namespace AlgorithmsUnitTest.Graphs
{
    public class GraphGenerator
    {
        public static Graph graph(){
            var g = new Graph(6);
            g.addEdge(0, 5);
            g.addEdge(2, 4);
            g.addEdge(2, 3);
            g.addEdge(1, 2);
            g.addEdge(0, 1);
            g.addEdge(3, 4);
            g.addEdge(3, 5);
            g.addEdge(0, 2);

            return g;
        }

        //directed acyclic graph
        public static DiGraph dag(){
            var dag = new DiGraph(7);

            dag.addEdge(0, 5);
            dag.addEdge(0, 2);
            dag.addEdge(0, 1);
            dag.addEdge(3, 6);
            dag.addEdge(3, 5);
            dag.addEdge(3, 4);
            dag.addEdge(5, 4);
            dag.addEdge(6, 4);
            dag.addEdge(6, 0);
            dag.addEdge(3, 2);
            dag.addEdge(1, 4);






            return dag;
        }

        public static Graph graph4ConnectedComponents() {
            var g = new Graph(13);
            g.addEdge(0, 5);
            g.addEdge(4, 3);
            g.addEdge(0, 1);
            g.addEdge(9, 12);
            g.addEdge(6, 4);
            g.addEdge(5, 4);
            g.addEdge(0, 2);
            g.addEdge(11, 12);
            g.addEdge(9,10);
            g.addEdge(0, 6);
            g.addEdge(7, 8);
            g.addEdge(9, 11);
            g.addEdge(5, 3);
            return g;
        }
    }


}