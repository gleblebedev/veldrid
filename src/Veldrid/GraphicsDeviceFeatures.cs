﻿namespace Veldrid
{
    public class GraphicsDeviceFeatures
    {
        public bool ComputeShader { get; }
        public bool GeometryShader { get; }
        public bool TessellationShaders { get; }
        public bool MultipleViewports { get; }
        public bool SamplerLodBias { get; }
        public bool DrawBaseVertex { get; }
        public bool DrawBaseInstance { get; }
        public bool FillModeWireframe { get; }
        public bool SamplerAnisotropy { get; }
        public bool DepthClipDisable { get; }
        public bool Texture1D { get; }
        public bool IndependentBlend { get; }

        public GraphicsDeviceFeatures(
            bool computeShader, 
            bool geometryShader, 
            bool tessellationShaders, 
            bool multipleViewports, 
            bool samplerLodBias, 
            bool drawBaseVertex, 
            bool drawBaseInstance, 
            bool fillModeWireframe, 
            bool samplerAnisotropy, 
            bool depthClipDisable,
            bool texture1D,
            bool independentBlend)
        {
            ComputeShader = computeShader;
            GeometryShader = geometryShader;
            TessellationShaders = tessellationShaders;
            MultipleViewports = multipleViewports;
            SamplerLodBias = samplerLodBias;
            DrawBaseVertex = drawBaseVertex;
            DrawBaseInstance = drawBaseInstance;
            FillModeWireframe = fillModeWireframe;
            SamplerAnisotropy = samplerAnisotropy;
            DepthClipDisable = depthClipDisable;
            Texture1D = texture1D;
            IndependentBlend = independentBlend;
        }
    }
}